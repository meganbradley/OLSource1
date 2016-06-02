---
title: Maintenance Plan (Reporting and Logging Page)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3a30b17a-3deb-446f-900a-62f88934a90f
---
# Maintenance Plan (Reporting and Logging Page)
  Use the **Reporting and Logging** dialog box to configure the reports and logs that are generated when maintenance plans are executed.  
  
## Options  
 **Generate a text file report**  
 Specify if you want [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] to write a text file report.  
  
 **Create a new file**  
 Create a new report file for each execution of the maintenance plan. By default, the report files are written to the computer hosting the instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] that contains this maintenance plan, in the folder established as the default log folder during [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] setup. To specify a different folder, enter the full path of the folder in the **Folder** text box, or click the browse button \(**...**\) and navigate to the desired folder.  
  
 **Append to file**  
 Append the report from each plan execution to the file specified in the **File name** text box. You may also specify a file by clicking the browse button and selecting a file from the dialog box.  
  
 **Send report to an e\-mail recipient**  
 Transmit the outcome of a maintenance plan execution via e\-mail. This option is only available if Database Mail is enabled and properly configured.  
  
 **Agent operator**  
 Select an agent operator from the list who will be the recipient of the e\-mail. This option is only available if mail is enabled and properly  
  
 **Log extended information**  
 Include more information in the log. Including this option will increase the size of the stored maintenance plan history.  
  
 **Log to remote server**  
 Logs maintenance plan history to a remote server.  
  
 **Connection**  
 Specifies the connection information to use when logging to a remote server.  
  
 **New**  
 Displays the **Connection Properties** dialog box. Used to configure new connection information for logging to a remote server.  
  
## See Also  
 [Maintenance Plans](../../Topics\TopicNameNotContainA/Maintenance-Plans.md)   
 [Database Mail](../../Topics\TopicNameNotContainA/Database-Mail.md)  
  
  