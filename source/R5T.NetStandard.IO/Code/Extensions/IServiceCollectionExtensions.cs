using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.L0017.D001;
using R5T.T0063;


namespace R5T.NetStandard.IO
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DirectoryServicesProvider"/> implementation of <see cref="IDirectoryServicesProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDirectoryServicesProvider(this IServiceCollection services,
            IServiceAction<ILoggerUnbound> loggerUnboundAction)
        {
            services
                .Run(loggerUnboundAction)
                .AddSingleton<IDirectoryServicesProvider, DirectoryServicesProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="FileServicesProvider"/> implementation of <see cref="IFileServicesProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddFileServicesProvider(this IServiceCollection services,
            IServiceAction<ILoggerUnbound> loggerUnboundAction)
        {
            services
                .Run(loggerUnboundAction)
                .AddSingleton<IFileServicesProvider, FileServicesProvider>();

            return services;
        }
    }
}
