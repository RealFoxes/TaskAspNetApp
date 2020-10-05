# TaskAspNetApp

В репозиторий приложил базу данных и пример Excel файла


Было создано веб-приложение по управлению договорами использующие ASP .NET Core, EntityFrameworkCore и библиотеку для взаимодейтсвия с Excel - "NPOI".

Модель:

ДОГОВОР
- ИДЕНТИФИКТОР 
- ШИФР ДОГОВОРА
- НАИМЕНОВАНИЕ ДОГОВОРА
- ЗАКАЗЧИК


ЭТАП ДОГОВОРА
- ИДЕНТИФИКТОР
- НАИМЕНОВАНИЕ ЭТАПА
- ДАТА НАЧАЛА
- ДАТА ОКОНЧАНИЯ
- ИДЕНТИФИКТОР ДОГОВОРА

Все пути у веб приложения:
 /Contracts/Index
 /Contracts/Import
 /api/Import/UploadFile ( Здесь необходим POST запрос с параметром file )
 /api/Contracts/GetContracts
 /api/Contracts/GetContractStages/{ID} (Тут требуется параметр с идентификатором договора Пример: "{Server}/api/Contracts/GetContractStages/9")
