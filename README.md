# unite-identity-data

Shared architecture, development workflows, and agent instructions:
[UNITE project documentation](https://github.com/dkfz-unite/.github/blob/main/README.md).

Identity data models and database services for PostgreSQL database
`unite_identity`, separate from the biomedical `unite_data` database.

The current repository contains one project, `Unite.Identity.Data`:

- `Entities/`: identity entities and enums.
- `Services/IdentityDbContext.cs`: PostgreSQL context and configuration.
- `Services/Mappers/`: explicit Fluent API entity mappings applied by the context.

The owner uses code first and keeps database mapping in mapper classes instead
of entity attributes. EF migration history and the model snapshot live in
[unite-identity-data-migrations](https://github.com/dkfz-unite/unite-identity-data-migrations).
Settle the entity/mapping changes, then generate, inspect, and apply a migration
locally and verify affected services before publishing. Migration development
can use a temporary sibling project reference or an updated published model
package, following the same workflow as domain-data migrations.
