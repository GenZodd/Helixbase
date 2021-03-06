﻿using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using Sitecore.Data.Items;

namespace Helixbase.Foundation.Content.Repositories
{
    /// <summary>
    ///     Retrieve Sitecore items using Glass
    /// </summary>
    public class ContentRepository : IContentRepository
    {
        private readonly IRequestContext _requestContext;

        public ContentRepository(IRequestContext requestContext)
        {
            _requestContext = requestContext;
        }

        public T GetItem<T>(GetItemOptions options) where T : class
        {
           return _requestContext.SitecoreService.GetItem<T>(options);
        }

        public object GetItem(GetItemOptions options)
        {
            return _requestContext.SitecoreService.GetItem(options);
        }

        public T GetCurrentItem<T>() where T : class
        {
            return _requestContext.GetContextItem<T>();
        }

        public object GetCurrentItem(GetKnownOptions options)
        {
            return _requestContext.GetContextItem(options);
        }

        public T GetCurrentItem<T>(GetKnownOptions options) where T : class
        {
            return _requestContext.GetContextItem<T>(options);
        }

        public T GetHomeItem<T>() where T : class
        {
            return _requestContext.GetHomeItem<T>();
        }

        public T GetHomeItem<T>(GetKnownOptions options) where T : class
        {
            return _requestContext.GetHomeItem<T>(options);
        }

        public T GetRootItem<T>() where T : class
        {
            return _requestContext.GetRootItem<T>();
        }

        public T GetRootItem<T>(GetKnownOptions options) where T : class
        {
            return _requestContext.GetRootItem<T>(options);
        }

        public Item ContextItem => _requestContext.ContextItem;
    }
}