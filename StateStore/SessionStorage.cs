using App_01_ServerManagement.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace App_01_ServerManagement.StateStore
{
    public class SessionStorage
    {

        private readonly ProtectedSessionStorage protectedSessionStorage;

        public SessionStorage(ProtectedSessionStorage protectedSessionStorage)
        {
            this.protectedSessionStorage = protectedSessionStorage;
        }

        public async Task<Server?> GetServerAsync()
        {
            var result = await protectedSessionStorage.GetAsync<Server>("server");
            if (result.Success)
                return result.Value;
            else
                return null;
        }

        public async Task SetServerAsync(Server? server)
        {
            await protectedSessionStorage.SetAsync("server", server);
        }
    }
}
