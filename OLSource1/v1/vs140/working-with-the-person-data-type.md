---
title: "Working with the Person Data Type"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: bd400158-053c-44ff-8c91-0d8c9c6ac3dd
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Working with the Person Data Type
You can add and manage people-related data in your LightSwitch application if you use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> data type. **Person** is a business type that's based on the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> type in the .NET Framework. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> data type is designed to store people’s identities: values that uniquely identify individuals.  
  
 You can store any identity value that you want in a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field, but LightSwitch makes some assumptions about the identity format depending on the authentication type of the application.  
  
-   For forms authentication, LightSwitch will use the form's logon name as the identity value.  
  
-   For Windows authentication, LightSwitch will use the Windows logon name of that user (for example, *Contoso\JoeSmith*)  
  
-   For SharePoint-enabled applications, including cloud business apps, the identity is the user’s primary email address.  
  
-   If your application doesn’t use authentication and users are anonymous, their identities are represented by empty strings.  
  
-   You can also use a special <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value that represents the identity of a user who's running the application in debug (F5) mode.  
  
## Info Properties  
 The entity class that's generated from your data model includes two properties for each <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> field: the property that contains the raw identity (type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) and a property that ends with an “Info” suffix of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (the info property). For example, the identity property “Employee” has a corresponding info property that's named “EmployeeInfo”. Similarly, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> identity property is paired with an **OwnerInfo** info property.  
  
 Info properties are read-only. The source of their data is a directory service. You can use the info property value in your code to write various kinds of business logic. For example, here’s how you can use the entity’s info property to send an email message when a user checks out a document:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If the identity property contains a value that the directory doesn’t recognize, the info property returns an object that represents the unresolved, raw identity, and the full-person information isn’t available.  
  
 SharePoint-enabled LightSwitch apps (cloud business apps) use either Active Directory or Azure Active Directory (for on-premises vs. cloud-based applications, respectively) to retrieve contact, organizational, and security-related information about people. If the application uses Windows or Forms authentication, only basic, security-related information is exposed through info properties.  
  
## Current User Data  
 Information about the current user of the application is available through the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> property of the global **Application** object (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>). As the following example shows, this property returns an object of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> type, so you can handle the current user and other users in the application in the same way.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> property retrieves the identity of the current user in a format that's appropriate for the authentication mechanism that the application uses.  
  
## See Also  
 [How to: Define Data Fields in a LightSwitch Database](../vs140/how-to--define-data-fields-in-a-lightswitch-database.md)   
 [How to: Implement Row Tracking](../vs140/how-to--implement-row-tracking.md)