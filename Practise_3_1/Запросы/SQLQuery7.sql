select pp.partner_name, sum(p.minimum_cost_for_partner * pp.products_amount) / count(pp.partners_id) as averagecheck 
from partner_products pp 
join products p on pp.products_id = p.products_id 
group by pp.partner_name 
order by averagecheck desc