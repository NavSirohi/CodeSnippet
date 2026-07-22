SELECT COUNT(*) AS new_york_employees FROM employees e JOIN departments d ON e.department_id = d.department_id JOIN locations l ON d.location_id = l.location_id WHERE l.city = 'New York';
