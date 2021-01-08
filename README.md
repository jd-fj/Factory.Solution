# Dr. Sillystringz's Factory

#### Friday project for week 4 of c#, Many-to-Many relationships, 1.8.2020

#### Taylor Delph

## Description

You've been contracted by the factory of the famous Dr. Sillystringz to build an application to keep track of their machine repairs. You are to build an MVC web application to manage their engineers, and the machines they are licensed to fix. The factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. There should be a many-to-many relationship between Engineers and Machines. An engineer can be licensed to repair (belong to) many machines (such as the Dreamweaver, the Bubblewrappinator, and the Laughbox) and a machine can have many engineers licensed to repair it.

## Software Requirements
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

#### Setup and Use (cloning)

* Open your terminal and ensure you are within the directory you'd like the file to be created in.
* Enter the following command `$ git clone `
* Once cloned, use the `$ cd LarryDavid.Solution/LarryDavid` command to navigate to the project directory.
* Enter `$ dotnet restore`