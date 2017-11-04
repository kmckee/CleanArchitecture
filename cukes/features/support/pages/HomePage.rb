class HomePage
  include PageObject
  page_url(FigNewton.base_url)
  h2(:name, id: 'name-header')
end