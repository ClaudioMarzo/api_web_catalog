STARTUP_FOLDER=./src/Catalog.API
INFRA_FODER=./src/Catalog.Infrastructure

run:
	dotnet run --project ${STARTUP_FOLDER}

restore:
	dotnet restore src

migrate:
	dotnet ef migrations add $(name) --startup-project=${STARTUP_FOLDER} --project=${INFRA_FODER}

up_docker:
	docker compose -f docker-compose.yml up -d catalog-database