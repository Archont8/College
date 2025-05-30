select datename(month, pp.date_of_sale) as months, sum(p.minimum_cost_for_partner * pp.products_amount) as resultcost 
from partner_products pp 
join products p on p.products_id = pp.products_id 
group by datename(month, pp.date_of_sale) 
order by resultcost desc