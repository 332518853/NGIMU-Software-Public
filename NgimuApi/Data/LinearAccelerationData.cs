﻿using NgimuApi.Maths;
using Rug.Osc;

namespace NgimuApi.Data
{
    /// <summary>
    /// Linear acceleration data received from the device.
    /// </summary>
    public sealed class LinearAccelerationData : DataBase
    {
        /// <summary>
        /// Gets the OSC address for this data object.
        /// </summary>
        public override string OscAddress { get { return "/linear"; } }

        /// <summary>
        /// Gets the linear acceleration in g.
        /// </summary>
        public Vector3 LinearAcceleration { get; private set; }

        /// <summary>
        /// Method called when an OSC message associated with this data object is received.
        /// </summary>
        /// <param name="message">Received OSC message.</param>
        /// <returns>True if the OSC message was successfully parsed.</returns>
        protected override bool OnMessageReceived(OscMessage message)
        {
            if (message.Count != 3)
            {
                return false;
            }

            if (!(message[0] is float))
            {
                return false;
            }

            if (!(message[1] is float))
            {
                return false;
            }

            if (!(message[2] is float))
            {
                return false;
            }

            LinearAcceleration = new Vector3((float)message[0], (float)message[1], (float)message[2]);

            return true;
        }

        internal override string CsvHeader
        {
            get
            {
                return Helper.ToCsv(
                        "Time (s)",
                        "X (g)", "Y (g)", "Z (g)"
                        );
            }
        }

        internal override string ToCsv(OscTimeTag firstTimestamp)
        {
            return Helper.ToCsv(
                    CreateTimestampString(firstTimestamp),
                    LinearAcceleration.X, LinearAcceleration.Y, LinearAcceleration.Z
                    );
        }
    }
}
