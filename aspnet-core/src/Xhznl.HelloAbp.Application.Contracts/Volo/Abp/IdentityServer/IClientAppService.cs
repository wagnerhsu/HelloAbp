﻿using System;
using Volo.Abp.Application.Services;

namespace Volo.Abp.IdentityServer
{
    public interface IClientAppService:ICrudAppService<ClientDto,Guid,GetClientListInput,CreateClientDto,UpdateClientDto>
    {
    }
}