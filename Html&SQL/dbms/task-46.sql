SELECT e.first_name, e.last_name, e.salary, m.first_name AS manager_name, m.salary AS manager_salary FROM employees e JOIN employees m ON e.manager_id = m.employee_id WHERE e.salary > m.salary;
