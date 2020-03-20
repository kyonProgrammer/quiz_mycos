# quiz_mycos

THIS QUIZ: 

Mycos c# quize

Mycos c# quize Every month in Mycos Technologies company has paid a providence fund for the employee depends on how many years they have been worked and how much rate that employee choose base on their salary. We would like to have a system to calculate the providence fund for employees in company since the day they start to work to present. The data we'll keep in database for employee should have at least first name, last name, date of birth, start workday, salary and pdv fund rate. (other will be extra point)

Conditions:

Employee that work less than 3 months will not receive the providence fund
Employee that work less than 1-year company will pad for 10% and can choose pvd rate not over 3%
Employee that work less than 3-year company will paid for 30% and can choose pvd rate not over 5%
Employee that work less that 5-year company will paid for 50% and can choose pvd rate not over 8%
Employee that work over 5-year company will paid for 80% and can choose pvd rate not over 12%
Ex. 1 Employee A has start to work at Mycos on 01 Jan 2020 with salary 20000 bath, until now A will have pvd fund = 0

Ex. 2 Employee B has start to work at mycos on 01 June 2019 with slary 20000 bath and pvd rate A paid is 3%, utill now B will have pdv funds = from Jun to Dec = 6 months, but first 3 months company didn't paid. So the pvd funds for 2019 = (20000 * 10 / 100) * 3 + (20000 * 3 / 100) * 3= 6000 + 1800 for 2020 will collect pvd fund = (20000 * 10 / 100) * 2 + (20000 * 3 / 100) * 2= 4000 +1200 The total of pvd fund that B collected is 12000 bath

Challenge:

Design the data model of the data described above (class).
Create a function or property to calculate the providence fund for each employee
Display the total providence fund that employee have been collected
Design database from the description above(schema).
Create a script to create a database with tables (as needed) with these default data (more will be extra point)
First name ||Last name || Date of birth || Start work date || Salary || Pvd fund rate || John || Wick || 02 Sep 1964 || 01 March 2004 || 46000 || 10 || Beyoncé || Knowles || 04 Sep 1981 || 16 Sep 2008 || 25000 || 3 || Justin || Bieber || 1 March 1994 || 01 Dec 2016 || 21000 || 3 || Justin || Timberlake|| 31 Jan 1981 || 20 Jan 2014 || 35000 || 5 || Taylor || Swift || 13 Dec 1989 || 01 May 2018 || 23000 || 4 ||

All code and script to create database and data should be publish on github with public link and can be execute.

Code should be implemented with c# with any platform (web or winform)
