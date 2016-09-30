---
title: "How to: Install a LightSwitch Application on a Server"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 09066aae-c762-42e5-be91-c98cd1d492fa
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Install a LightSwitch Application on a Server
One option for deploying a [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)]-based application to a server running Internet Information Services (IIS) is to package the application in a .zip file. This package can be installed by a server administrator by using the **Import Application Package** wizard in the IIS Manager application.  
  
### To install an application on the server  
  
1.  In IIS Manager, expand the **Sites** node in the **Connections** pane and select the web site where you want to deploy the application.  
  
2.  In the **Actions** pane, click **Import Application**.  
  
3.  In the **Import Application Package** wizard, click **Browse**  
  
4.  In the **Open** dialog box, locate the directory where the package (.zip) file is located and select the file, and then click **Open**.  
  
5.  In the **Import Application Package** wizard, click **Next**.  
  
6.  On the **Select the Contents of the Package** page, verify the selections and then click **Next**.  
  
7.  On the **Enter Application Package Information** page, select the **Connection String** field and enter the connection string for the computer running SQL Server that will host the application database.  
  
8.  In the **DatabaseServer** field, enter the name of the computer running SQL Server. This must match the name that was specified in the connection string.  
  
9. In the **DatabaseUserName** field, enter the user name that the application will use to connect to the application database.  
  
10. In the **DatabaseUserPassword** fields, enter and confirm the password for the user.  
  
11. In the **Application Administrator User Name** field, enter the user name for the user who will have administrative access to the application, and then click **Next**.  
  
    > [!NOTE]
    >  If you have enabled Forms authentication for you application, you will also need to enter the **Full Name** and **Password** for the default administrator. If authentication is not enabled, this field does not appear.  
  
     If you are installing the application for the first time, the wizard will begin the installation. If you are installing an update to an existing applications, you will see the **Overwrite Existing Files** page. Choose to append or delete the files, and then click **Next** to begin the installation.  
  
## See Also  
 [How to: Deploy a 3-tier Application](../vs140/how-to--deploy-a-three-tier-lightswitch-application.md)   
 [Deploying LightSwitch Applications](../vs140/deploying-lightswitch-applications.md)   
 [Deployment: Distributing and Maintaining Your Application](../vs140/deployment--distributing-and-maintaining-your-application.md)