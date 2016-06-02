---
title: Searching for Reports and Other Items (Report Builder  and SSRS)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6a586659-5c2b-453b-8f40-a3a469277b17
---
# Searching for Reports and Other Items (Report Builder  and SSRS)
  You can use Report Manager to search a report server for specific items by name or description. You can search for published reports, report models, folders, shared data sources, and resources. You cannot search for schedules, owners, role assignments, specific snapshots in report history, or subscriptions. The search is performed on the report server database where the items are stored.  
  
> [!NOTE]  
>  Performing a file system search will not return search results for items managed by a report server.  
  
-   To search for items in Report Manager, type a search string in the **Search for** text box at the top of the page. Searches begin at the top node in the folder hierarchy and then proceed through every branch. If you do not have permission to access a specific branch, that branch is skipped. This applies to My Reports folders that belong to other users, and to other folders that are not generally available. Only reports and items that you have permission to view are included in the search results.  
  
-   To search for an item by name or description, specify all or part of the text that you want to match. The search string is not case\-sensitive. You cannot use search operators such as plus \(\+\) or minus \(–\) symbols to require or exclude search criteria.  
  
-   To search for specific text within a report, use the toolbar at the top of the report.  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Token\Other/ssRBRDDup_md.md)]  
  
## See Also  
 [Finding and Viewing Reports in Report Manager &#40;Report Builder and SSRS&#41;](../Topic/Finding%20and%20Viewing%20Reports%20in%20Report%20Manager%20\(Report%20Builder%20and%20SSRS\).md)   
 [Using My Reports &#40;Report Builder and SSRS&#41;](../Topic/Using%20My%20Reports%20\(Report%20Builder%20and%20SSRS\).md)   
 [Finding, Viewing, and Managing Reports &#40;Report Builder and SSRS &#41;](../Topic/Finding,%20Viewing,%20and%20Managing%20Reports%20\(Report%20Builder%20and%20SSRS%20\).md)   
 [Open and Close a Report &#40;Report Manager&#41;](../Topic/Open%20and%20Close%20a%20Report%20\(Report%20Manager\).md)  
  
  