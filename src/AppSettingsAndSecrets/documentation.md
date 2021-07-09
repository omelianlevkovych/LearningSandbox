# Secrets
Secrets in an application.

Any sensetive piece of data that should not be widely known or should not be exposed.
For istance:
- Connection strings or database credentials
- Passwords
- OAuth Client secrets
- 3rd party API keys

# Why secrets should be secured
Because after a not trusted person get our secrets we will get compromised.

# The way of getting data from appsettings.json
- By direct IConfiguration (configuration.GetValue<T> or configuration.GetSection).
- Create model to bind the data. Drowbacks is that naming should be synchronized.
- By using IOptions

