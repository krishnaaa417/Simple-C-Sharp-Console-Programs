using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    class leetcode
    {
    /* Write your T-SQL query statement below */
SELECT P.product_name, O.unit
FROM Products P
JOIN (
    SELECT product_id, SUM(unit) AS unit
    FROM Orders
    WHERE order_date BETWEEN '2020-02-01' AND '2020-02-29'  
    GROUP BY product_id
    HAVING SUM(unit) >= 100  
) O 
ON P.product_id = O.product_id;
    }
}
