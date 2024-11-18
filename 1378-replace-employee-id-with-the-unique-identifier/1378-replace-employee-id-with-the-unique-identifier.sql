/* Write your T-SQL query statement below */
SELECT unique_id,name from Employees e LEFT JOIN EmployeeUNI eu ON e.id = eu.id