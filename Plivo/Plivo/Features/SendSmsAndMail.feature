Feature: SendSmsAndMail
	
	This featue is for configuring SMS and mail components.

@UI @Sanity

  Scenario: Verify that SMS and Mail apps are connected to eachother.
  
    Given I have a valid url to launch the application.
     Then I will create an App.
      And I select Get started to start building an App.
     Then I will create new page by giving the name "TestApp".
	 Then I Select Messaging Menu.
      And I drag drop the "Send an SMS" component
     Then I enter the following details to the SMS Component
      | PhoneNumber | Message     | 
      | 123456789   | Hello Plivo | 
      And I connect the components start and SMS.
     Then I drag drop the "Send an Email" component
	  And I Adjust space on Canvas. 
	 Then I enter the following details to the Mail Component
      | SmtpHost        | Port | UserName           | Password | From               | To            | Subject | cc              | Message | 
      | http:/gmail.com | 645  | anjan555@gmail.com | abc@123  | anjan555@gmail.com | xyz@gmail.com | Plivo!! | anjan@gmail.com | Plivo   | 
     Then I connect Sms and Email components.
	 Then I select basic menu.
	  And I drag drop the "Hang Up or Exit" component
	  And I drag drop the "Hang Up or Exit" component
	  And I drag drop the "Hang Up or Exit" component
     Then I adjust exit apps on canvas.  
     Then I connect it with Mail and SMS components.
	  And I Verify that all thecomponents are on canvas.
