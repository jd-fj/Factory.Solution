# Dr. Sillystringz's Factory 🏭

#### Friday project for week 4 of c#, Many-to-Many relationships, 1.8.2020

#### Taylor Delph

## Description

  You've been contracted by the factory of the famous Dr. Sillystringz to build an application to keep track of their machine repairs. You are to build an MVC web application to manage their engineers, and the machines they are licensed to fix. The factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. There should be a many-to-many relationship between Engineers and Machines. An engineer can be licensed to repair (belong to) many machines (such as the Dreamweaver, the Bubblewrappinator, and the Laughbox) and a machine can have many engineers licensed to repair it.

![Splash Page](./ReadMeAssets/home.gif)

## 💻  Software Requirements
* A code editor like [VSCode](https://code.visualstudio.com/download)
* With [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) installed
* [MySQL](https://dev.mysql.com/downloads/file/?id=484914)

  * Click the 'No thanks, just start my download' link.
  * Follow along with the installer until you reach the Configuration page. Then select the following options:
  * Use Legacy Password Encryption.
  * Set password to **epicodus** and then click **Finish**.
  * Open the terminal and enter the command `echo 'export PATH="/usr/local/mysql//bin:$PATH"'>>~/.bash_profile`
  * Type `source ~/.bash_profile` in the terminal to verify that MySQL was installed.
  * Enter `mysql -uroot -pepicodus` or `mysql -uroot -p{your_password}` in the terminal to verify the installation. You will know it's installed when you gain access to the `mysql>` command line.


* [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391)
  * Select the 'No thanks, just start my download' link.
  * Install MySQL Workbench in the Applications folder.
  * Open MySQL Workbench and select the `Local instance 3306` server. You will need to enter the password **epicodus** (or the password you set).


## 🏗️  Setup and Use via cloning
* Open your terminal and ensure you are within the directory you'd like the file to be created in.
* Enter the following command `$ git clone https://github.com/taylulz/Factory.git`
* Once cloned, use the `$ cd Factory/Factory` command to navigate to the project directory.
* Enter `$ dotnet restore`


#### AppSettings.Json
* Create a file in Factory/Factory folder named `appsettings.json`
* Copy and paste the following snippet to the file (if you used your own password, replace 'epicodus' with the one you've set)

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=taylor_delph;uid=root;pwd=epicodus;"
  }
}
```

#### Import Database with Entity Framework Core
* Now enter `$ dotnet ef database update` to create database in MySQL.
* To run the console application, enter `$ dotnet run`
* Your command line will open a server (likely `http://localhost:5000/`). Navigate to this URL in your browser to view the project.

#### Import Database with SQL Schema
* Copy and paste the following Schema Create Statement in MySQL Workbench to create this database with it's respective tables.
```
CREATE DATABASE `taylor_delph` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE taylor_delph;

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `Engineers`;
CREATE TABLE `Engineers` (
  `EngineerId` int(11) NOT NULL AUTO_INCREMENT,
  `EngineerName` longtext,
  PRIMARY KEY (`EngineerId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `Licenses`;
CREATE TABLE `Licenses` (
  `LicensesId` int(11) NOT NULL AUTO_INCREMENT,
  `EngineerId` int(11) NOT NULL,
  `MachineId` int(11) NOT NULL,
  PRIMARY KEY (`LicensesId`),
  KEY `IX_Licenses_EngineerId` (`EngineerId`),
  KEY `IX_Licenses_MachineId` (`MachineId`),
  CONSTRAINT `FK_Licenses_Engineers_EngineerId` FOREIGN KEY (`EngineerId`) REFERENCES `engineers` (`EngineerId`) ON DELETE CASCADE,
  CONSTRAINT `FK_Licenses_Machines_MachineId` FOREIGN KEY (`MachineId`) REFERENCES `machines` (`MachineId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `Machines`;
CREATE TABLE `Machines` (
  `MachineId` int(11) NOT NULL AUTO_INCREMENT,
  `MachineName` longtext,
  PRIMARY KEY (`MachineId`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```

## 🛠️ Technologies Used
* _GitBash_
* _Visual Studio Code_
* _GitHub_
* _C# v 7.3_
* _.NET Core v 2.2_
* _MSTest_
* _ASP.NET Core MVC_
* _Bootstrap_
* _CSS_
* _cshtml_
* _MySQL Workbench_
* _Entity Framework Core_
* _[SQL Designer](https://ondras.zarovi.cz/sql/demo/)_

## 🐞 Known Bugs

No known bugs at this time

## 📫 Contact details

If you run into any problems with the site, or need to get in touch with Dr. Sillystringz, please [email me here](mailto:taylulzcode@gmail.com)

## 📗 License

MIT License