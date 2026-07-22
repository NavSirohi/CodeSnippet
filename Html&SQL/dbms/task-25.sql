SELECT MONTH(hire_date) AS month_no, COUNT(*) AS total FROM employees GROUP BY MONTH(hire_date) ORDER BY month_no;
