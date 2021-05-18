﻿using System;
using Microsoft.Extensions.DependencyInjection;
using PnP.Core.Transformation.Services.Core;
using PnP.Core.Transformation.Services.MappingProviders;

namespace PnP.Core.Transformation.Services.Builder
{
    /// <summary>
    /// Used to configure PnP Core Transformation
    /// </summary>
    public interface IPnPTransformationBuilder
    {
        /// <summary>
        /// Collection of services for Dependecy Injection
        /// </summary>
        IServiceCollection Services { get; }

        /// <summary>
        /// Sets a custom <see cref="ITransformationStateManager" /> to use to handle the state of a transformation process
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPnPTransformationBuilder WithTransformationStateManager<T>()
            where T : class, ITransformationStateManager;

        /// <summary>
        /// Sets a custom <see cref="ITransformationDistiller" /> to defines a list of pages to transform
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPnPTransformationBuilder WithTransformationDistiller<T>()
            where T : class, ITransformationDistiller;

        /// <summary>
        /// Sets a custom <see cref="IPageTransformator" /> to use to transform pages
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPnPTransformationBuilder WithPageTransformator<T>()
            where T : class, IPageTransformator;

        /// <summary>
        /// Sets a custom <see cref="ITransformationExecutor" /> that manages the transformation of one or more pages
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPnPTransformationBuilder WithTransformationExecutor<T>()
            where T : class, ITransformationExecutor;

        /// <summary>
        /// Customizes the default transformation options for the pages
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        IPnPTransformationBuilder WithPageOptions(Action<PageTransformationOptions> options);

        /// <summary>
        /// Sets a custom <see cref="IWebPartMappingProvider" /> to use for the default transformation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPnPTransformationBuilder WithWebPartMappingProvider<T>()
            where T : class, IWebPartMappingProvider;

        /// <summary>
        /// Sets a custom <see cref="IPageLayoutMappingProvider" /> to use for the default transformation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPnPTransformationBuilder WithPageLayoutMappingProvider<T>()
            where T : class, IPageLayoutMappingProvider;

        /// <summary>
        /// Sets a custom <see cref="ITaxonomyMappingProvider" /> to use for the default transformation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPnPTransformationBuilder WithTaxonomyMappingProvider<T>()
            where T : class, ITaxonomyMappingProvider;

        /// <summary>
        /// Sets a custom <see cref="IMetadataMappingProvider" /> to use for the default transformation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPnPTransformationBuilder WithMetadataMappingProvider<T>()
            where T : class, IMetadataMappingProvider;

        /// <summary>
        /// Sets a custom <see cref="IUrlMappingProvider" /> to use for the default transformation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPnPTransformationBuilder WithUrlMappingProvider<T>()
            where T : class, IUrlMappingProvider;

        /// <summary>
        /// Sets a custom <see cref="IHtmlMappingProvider" /> to use for the default transformation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPnPTransformationBuilder WithHtmlMappingProvider<T>()
            where T : class, IHtmlMappingProvider;

        /// <summary>
        /// Sets a custom <see cref="IUserMappingProvider" /> to use for the default transformation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPnPTransformationBuilder WithUserMappingProvider<T>()
            where T : class, IUserMappingProvider;

        /// <summary>
        /// Sets a custom <see cref="IMappingProvider" /> to use for all transformations
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPnPTransformationBuilder WithMappingProvider<T>()
            where T : class, IMappingProvider;

        /// <summary>
        /// Adds a object to intercept a page before the transformation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPnPTransformationBuilder AddPagePreTransformation<T>()
            where T : class, IPagePreTransformation;

        /// <summary>
        /// Adds a object to intercept a page after the transformation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPnPTransformationBuilder AddPagePostTransformation<T>()
            where T : class, IPagePostTransformation;
    }
}
