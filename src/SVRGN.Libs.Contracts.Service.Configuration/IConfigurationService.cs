using SVRGN.Libs.Contracts.Service.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Configuration
{
    /// <summary>
    /// the service holding the configuration values
    /// </summary>
    public interface IConfigurationService : IService
    {
        #region Properties

        #endregion Properties

        #region Methods

        #region Add: adds a config value
        /// <summary>
        /// adds a config value
        /// </summary>
        /// <typeparam name="T">the Type of the config value</typeparam>
        /// <param name="Name">the name of the config value</param>
        /// <param name="Value">the value itself</param>
        /// <returns>true, if the value could be added successfully</returns>
        bool Add<T>(string Name, T Value);
        #endregion Add

        #region SetRelativeFilenameAndReload
        /// <summary>
        /// sets a config file name relative to the working directory and reloads the config.
        /// </summary>
        /// <param name="Filename">the filename, relative to the working directory (typically the execuzable dir)</param>
        void SetRelativeFilenameAndReload(string Filename);
        #endregion SetRelativeFilenameAndReload

        #region Exists: checks if a config value exists - should be called upfront Get
        /// <summary>
        /// checks if a config value exists - should be called upfront Get
        /// </summary>
        /// <typeparam name="T">The Type of the checked value</typeparam>
        /// <param name="Name">the name of the value to check</param>
        /// <returns>true, if the value exists, false if not</returns>
        bool Exists<T>(string Name);
        #endregion Exists

        #region Get: Retrieves a specific config value
        /// <summary>
        /// Retrieves a specific config value
        /// </summary>
        /// <typeparam name="T">the Type of the value</typeparam>
        /// <param name="Name">the name of the config value</param>
        /// <returns>the value itself or null, if it has not been found</returns>
        T Get<T>(string Name);
        #endregion Get

        #endregion Methods
    }
}
