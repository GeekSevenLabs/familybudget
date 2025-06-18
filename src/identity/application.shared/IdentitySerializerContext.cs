using System.Text.Json.Serialization;
using FamilyBudget.Identity.Application.Shared.Users.Create;

namespace FamilyBudget.Identity.Application.Shared;

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]

#region Users

[JsonSerializable(typeof(CreateUserRequest))]

#endregion
public partial class IdentitySerializerContext : JsonSerializerContext;