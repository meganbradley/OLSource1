---
title: "Working with the Person Data Type"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: bd400158-053c-44ff-8c91-0d8c9c6ac3dd
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Working with the Person Data Type
You can add and manage people-related data in your LightSwitch application if you use the `Person` data type. **Person** is a business type that's based on the `String` type in the .NET Framework. The `Person` data type is designed to store people’s identities: values that uniquely identify individuals.  
  
 You can store any identity value that you want in a `Person` field, but LightSwitch makes some assumptions about the identity format depending on the authentication type of the application.  
  
-   For forms authentication, LightSwitch will use the form's logon name as the identity value.  
  
-   For Windows authentication, LightSwitch will use the Windows logon name of that user (for example, *Contoso\JoeSmith*)  
  
-   For SharePoint-enabled applications, including cloud business apps, the identity is the user’s primary email address.  
  
-   If your application doesn’t use authentication and users are anonymous, their identities are represented by empty strings.  
  
-   You can also use a special `TestUser` value that represents the identity of a user who's running the application in debug (F5) mode.  
  
## Info Properties  
 The entity class that's generated from your data model includes two properties for each `Person` field: the property that contains the raw identity (type `String`) and a property that ends with an “Info” suffix of type `PersonInfo` (the info property). For example, the identity property “Employee” has a corresponding info property that's named “EmployeeInfo”. Similarly, the `Owner` identity property is paired with an **OwnerInfo** info property.  
  
 Info properties are read-only. The source of their data is a directory service. You can use the info property value in your code to write various kinds of business logic. For example, here’s how you can use the entity’s info property to send an email message when a user checks out a document:  
  
```vb  
Private Partial Sub Documents_Updating(entity As Document)  
If entity.Details.Properties.CheckedOutTo.IsChanged AndAlso Not String.IsNullOrEmpty(entity.CheckedOutTo) Then  
  
Dim owner As O365PersonInfo = entity.OwnerInfo  
Dim currentUser As O365PersonInfo = entity.CheckedOutToInfo  
  
If String.IsNullOrEmpty(owner.FullName) OrElse String.IsNullOrEmpty(currentUser.FullName) Then  
' We could not resolve the owner or the current user of the document.  
' Continue without sending email.  
Return  
End If  
Dim emailBody As String = "Your document " & Convert.ToString(entity.AssetNumber) & " (" & Convert.ToString(entity.Description) & ") has been checked out to " & Convert.ToString(entity.CheckedOutToInfo.FullName)  
  
SendEmail("DocumentTracker@example.com", entity.OwnerInfo.Email, "Document " & Convert.ToString(entity.AssetNumber) & " checked out", emailBody)  
End If  
End Sub  
  
```  
  
```c#  
partial void Documents_Updating(Document entity)  
{  
    if (entity.Details.Properties.CheckedOutTo.IsChanged  
        && !string.IsNullOrEmpty(entity.CheckedOutTo))  
    {  
  
        O365PersonInfo owner = entity.OwnerInfo;  
        O365PersonInfo currentUser = entity.CheckedOutToInfo;  
  
        if (string.IsNullOrEmpty(owner.FullName)  
            || string.IsNullOrEmpty(currentUser.FullName))  
        {  
            // We could not resolve the owner or the current user of the document.  
            // Continue without sending email.  
            return;  
        }  
        string emailBody = "Your document " + entity.AssetNumber  
            + " (" + entity.Description + ") has been checked out to "  
            + entity.CheckedOutToInfo.FullName;  
  
        SendEmail("DocumentTracker@example.com",   
            entity.OwnerInfo.Email,   
            "Document " + entity.AssetNumber + " checked out",   
            emailBody);  
    }  
}  
```  
  
 If the identity property contains a value that the directory doesn’t recognize, the info property returns an object that represents the unresolved, raw identity, and the full-person information isn’t available.  
  
 SharePoint-enabled LightSwitch apps (cloud business apps) use either Active Directory or Azure Active Directory (for on-premises vs. cloud-based applications, respectively) to retrieve contact, organizational, and security-related information about people. If the application uses Windows or Forms authentication, only basic, security-related information is exposed through info properties.  
  
## Current User Data  
 Information about the current user of the application is available through the `User` property of the global **Application** object (`Application.User`). As the following example shows, this property returns an object of `PersonInfo` type, so you can handle the current user and other users in the application in the same way.  
  
```vb  
Private Partial Sub Documents_Inserting(entity As Document)  
' If the Owner has not been set, assume the current user is the owner  
If String.IsNullOrEmpty(entity.Owner) Then  
entity.Owner = Application.User.PersonId  
End If  
End Sub  
  
```  
  
```c#  
partial void Documents_Inserting(Document entity)  
{  
    // If the Owner has not been set, assume the current user is the owner  
    if (string.IsNullOrEmpty(entity.Owner))  
    {  
        entity.Owner = Application.User.PersonId;  
    }  
}  
```  
  
 The `PersonId` property retrieves the identity of the current user in a format that's appropriate for the authentication mechanism that the application uses.  
  
## See Also  
 [How to: Define Data Fields in a LightSwitch Database](../vs140/how-to--define-data-fields-in-a-lightswitch-database.md)   
 [How to: Implement Row Tracking](../vs140/how-to--implement-row-tracking.md)