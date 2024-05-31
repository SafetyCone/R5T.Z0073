using System;

using R5T.T0131;


namespace R5T.Z0073.Z000
{
    /// <summary>
    /// Absolutely-named, fundamental, stringly-typed directory names
    /// (of Rivet-specific opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
        /// <summary>
        /// <para><value>_Types</value></para>
        /// </summary>
        public string _Types => "_Types";

        /// <summary>
        /// <para><value>Classes</value></para>
        /// </summary>
        public string Classes => "Classes";

        /// <summary>
        /// <para><value>Code</value></para>
        /// </summary>
        public string Code => "Code";

        /// <summary>
        /// <para><value>Definitions</value></para>
        /// </summary>
        public string Definitions => "Definitions";

        /// <summary>
        /// <para><value>Forms</value></para>
        /// </summary>
        public string Forms => "Forms";

        /// <summary>
        /// <para><value>Implementations</value></para>
        /// </summary>
        public string Implementations => "Implementations";

        /// <summary>
        /// <para><value>Interfaces</value></para>
        /// </summary>
        public string Interfaces => "Interfaces";

        /// <summary>
        /// <para><value>Layouts</value></para>
        /// </summary>
        public string Layouts => "Layouts";

        /// <summary>
        /// <para><value>Services</value></para>
        /// </summary>
        public string Services => "Services";

        /// <summary>
        /// <para><value>Strong Types</value></para>
        /// </summary>
        public string Strong_Types => "Strong Types";
    }
}
