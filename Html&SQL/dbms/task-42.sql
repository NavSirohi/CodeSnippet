SELECT e.*, s.grade FROM employees e JOIN salary_grade s ON e.salary BETWEEN s.lowest_sal AND s.highest_sal;
