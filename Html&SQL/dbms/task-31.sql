SELECT MONTH(hire_date) AS month_no, COUNT(*) AS total FROM employees WHERE YEAR(hire_date) = 1985 GROUP BY MONTH(hire_date);
