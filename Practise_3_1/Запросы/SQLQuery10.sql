select mt.material_type as materialname, round((count(pp.products) * 100.0) / sum(count(pp.products)) over(), 2) as productcounts, sum(p.minimum_cost_for_partner * pp.products_amount) as resultcost from partner_products pp 
join products p on pp.products_id = p.products_id 
join material_type mt on mt.material_type_id = p.material_type_id 
group by mt.material_type