When(/^I visit the homepage$/) do
  visit(HomePage)
end

Then(/^the homepage should have the name "([^"]*)"$/) do |expected_name|
  on(HomePage).name.should == expected_name
end