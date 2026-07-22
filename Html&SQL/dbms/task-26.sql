SELECT YEAR(hire_date) AS year_no, MONTH(hire_date) AS month_no, COUNT(*) AS total FROM employees GROUP BY YEAR(hire_date), MONTH(hire_date) ORDER BY year_no, month_no;
