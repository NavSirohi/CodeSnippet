SELECT j.job_title, COUNT(e.employee_id) AS total_employees FROM jobs j LEFT JOIN employees e ON j.job_id = e.job_id GROUP BY j.job_title;
