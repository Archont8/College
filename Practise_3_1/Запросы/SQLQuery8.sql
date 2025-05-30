select pp.partner_name, count(distinct(p.products_name)) as productcounts 
from partner_products pp 
join products p on pp.products_id = p.products_id 
group by pp.partner_name 
having count(p.products_name) > 3