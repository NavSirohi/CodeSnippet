SELECT s.grade, COUNT(e.employee_id) AS total_employees FROM salary_grade s JOIN employees e ON e.salary BETWEEN s.lowest_sal AND s.highest_sal WHERE e.salary BETWEEN 2000 AND 5000 GROUP BY s.grade;
