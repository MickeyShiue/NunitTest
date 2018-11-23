# NunitTest(專案價構)

* Mickey.Domain  
* Mickey.DataAccess
* Mickey.Service 
* Mickey.Web
* Mickey.Service.Tests

## Domain 專案

通常會拿來放 Domain Model、DTO (Data Transfer Object) 等等

## DataAccess 專案

與資料庫建立橋樑，用來操作 Select、Create、Update、Delete 等動作，有些人會把 DataAccess 層 與 Domain 層合併為一個專案稱之 Model 層，內含 DTO，與資料庫操作等動作

## Service 專案

通常給 Applaction 呼叫，而 Service 層會參考 DataAccess 層去操作資料，Service 通常負責商業邏輯的部分居多，而 CURD 透過 DataAccess 層來操作，而應用程式只要跟 Service 層產生關聯，無須知道 DataAccess 背後使用哪一種ORM去操作資料，萬一有一天要換資料庫或者ORM，只需修改 DataAccess 層即可，這樣的做法可以讓應用程式避免直接依賴 DataAccess 層

## TEST 專案

用來進行 Service 單元測試
### Using Package
* [NUnit](http://nunit.org/)
* [NUnit3TestAdapter](https://github.com/nunit/docs)
* [NSubstitute](https://www.nuget.org/packages/NSubstitute/) 可以透過套件管理主控台 => Install-Package NSubstitute -Version 3.1.0
