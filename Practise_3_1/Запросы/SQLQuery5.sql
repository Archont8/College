select pp.partner_name, pt.products_type from partner_products pp inner join products p on pp.products_id = p.products_id join product_type pt on pt.product_type_id = p.product_type_id 
where pt.products_type = 'ламинат' 
group by pt.products_type, pp.partner_name 
order by pp.partner_name