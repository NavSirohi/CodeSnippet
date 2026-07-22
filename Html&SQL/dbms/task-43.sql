SELECT s.grade, COUNT(e.employee_id) AS total_employees FROM salary_grade s LEFT JOIN employees e ON e.salary BETWEEN s.lowest_sal AND s.highest_sal GROUP BY s.grade;
