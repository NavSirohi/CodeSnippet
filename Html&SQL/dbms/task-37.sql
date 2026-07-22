SELECT d.department_name, COUNT(e.employee_id) AS total_employees FROM departments d JOIN employees e ON d.department_id = e.department_id GROUP BY d.department_name;
