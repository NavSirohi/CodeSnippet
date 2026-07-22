SELECT department_id FROM employees WHERE MONTH(hire_date) = 4 AND YEAR(hire_date) = 1985 GROUP BY department_id HAVING COUNT(*) >= 3;
