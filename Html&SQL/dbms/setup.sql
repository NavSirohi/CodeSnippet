CREATE TABLE locations(location_id INT PRIMARY KEY, city VARCHAR(30), regional_group VARCHAR(30));
CREATE TABLE departments(department_id INT PRIMARY KEY, department_name VARCHAR(30), location_id INT);
CREATE TABLE jobs(job_id INT PRIMARY KEY, job_title VARCHAR(30));
CREATE TABLE employees(employee_id INT PRIMARY KEY, first_name VARCHAR(30), last_name VARCHAR(30), salary DECIMAL(10,2), commission DECIMAL(10,2), department_id INT, job_id INT, manager_id INT, hire_date DATE);
CREATE TABLE salary_grade(grade INT PRIMARY KEY, lowest_sal DECIMAL(10,2), highest_sal DECIMAL(10,2));

-- Run this file first. Then run any task file below.
