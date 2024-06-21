Цели проекта:
- Научится реализовывать ASP.Net core приложения в стиле REST с использованием БД (EF)


Кракткое описание функционала приложения:
- Сервис для обратнйо связи с пользователями


Структура решения:

- sample : Примеры подключения и использования приложения
- src
    - FeedbackFlow.Api : Основная (запускаемая) сборка REST API backend приложения
    - FeddbackFlow.Data.EfModels : Сборка с моделями и конфигурациями для БД (EF)
    - FeedbackFlow.Api.Logic : Сборка с реализацией логики приложения
    - FeedbackFlow.Data.MigrationPostgreSql : Миграции для PostgreSQL
    - FeedbackFlow.Infrastructure : Механизмы и инструменты для работы прижения
- test : Сбоки с тестами
    
