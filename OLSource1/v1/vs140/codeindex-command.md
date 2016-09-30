---
title: "CodeIndex Command"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "command-line tools [Team Foundation Server]"
  - "TFSConfig"
  - "CodeIndex command [Team Foundation Server]"
ms.assetid: b79568d4-6a64-4ca9-a1ee-3e57f92a9c5c
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CodeIndex Command
Use the **CodeIndex** command to manage code indexing on Team Foundation Server. For example, you might want to reset the index to fix CodeLens information, or turn off indexing to investigate server performance issues.  
  
 **Required Permissions**  
  
 To use the **CodeIndex** command, you must be a member of the **Team Foundation Administrators** security group. See [Permission reference for Team Foundation Server](assetId:///39997de5-b7fb-4777-b779-07de0543abe6).  
  
> [!NOTE]
>  Even if you log on with administrative credentials, you must open an elevated Command Prompt window to run this command. You must also run this command from the application tier for Team Foundation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|**Argument**|**Description**|  
|------------------|---------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Specifies the name of the team project collection. If the name has spaces, enclose the name with quotation marks, for example, "Fabrikam Web Site".|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Specifies the identification number of the team project collection.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Specifies the path to a code file.|  
  
|**Option**|**Description**|  
|----------------|---------------------|  
|**/indexingStatus**|Show the status and configuration of the code indexing service.|  
|**/setIndexing:**[ on &#124; off &#124; keepupOnly ]|-   **on**: Start indexing all changesets.\<br />-   **off**: Stop indexing all changesets.\<br />-   **keepupOnly**: Stop indexing previously created changesets and start indexing new changesets only.|  
|**/ignoreList:**[ add &#124; remove &#124; removeAll &#124; view ] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>\<br />\<br /> You can use the wildcard character (*) at the start, end, or both ends of the server path.|Specifies a list of code files and their paths that you don't want indexed.\<br />\<br /> -   **add**: Add the file that you don't want indexed to the ignored file list.\<br />-   **remove**: Remove the file that you want indexed from the ignored file list.\<br />-   **removeAll**: Clear the ignored file list and start indexing all files.\<br />-   **view**: See all the files that aren't being indexed.|  
|**/listLargeFiles [/fileCount:** <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> **/minSize:** <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>]|Shows the specified number of files that exceeds the specified size in KB. You can then use the **/ignoreList** option to exclude these files from indexing.|  
|**/reindexAll**|Clear previously indexed data and restart indexing.|  
|**/destroyCodeIndex [/noPrompt]**|Delete the code index and remove all indexed data. Does not require confirmation if you use the **/noPrompt** option.|  
|**/temporaryDataSizeLimit**:[ view &#124; <<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>> &#124; disable ]|Control how much temporary data that CodeLens creates when processing changesets. The default limit is 2 GB.\<br />\<br /> -   **view**: Show the current size limit.\<br />-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>: Change the size limit.\<br />-   **disable**: Remove the size limit.\<br />\<br /> This limit is checked before CodeLens processes a new changeset. If temporary data exceeds this limit, CodeLens will pause processing past changesets, not new ones. CodeLens will restart processing after the data is cleaned up and falls below this limit. Cleanup runs automatically once a day. This means temporary data might exceed this limit until cleanup starts running.|  
|**/indexHistoryPeriod**:[ view &#124; all &#124; <<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>> ]|Control how long to index your change history. This affects how much history CodeLens shows you. The default limit is 12 months. This means CodeLens shows your change history from the last 12 months only.\<br />\<br /> -   **view**: Show the current number of months.\<br />-   **all**: Index all change history.\<br />-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>: Change the number of months used to index change history.|  
|**/collectionName:** <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Specifies the name of the team project collection on which to run the **CodeIndex** command. Required if you don't use **/CollectionId**.|  
|**/collectionId:** <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Specifies the identification number of the team project collection on which to run the **CodeIndex** command. Required if you don't use **/CollectionName**.|  
  
## Examples  
  
> [!NOTE]
>  The example companies, organizations, products, domain names, email addresses, logos, people, places, and events depicted herein are fictitious.  No association with any real company, organization, product, domain name, email address, logo, person, places, or events is intended or should be inferred.  
  
 To see the code indexing status and configuration:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 To start indexing all changesets:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 To stop indexing previously created changesets and start indexing new changesets only:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 To find up to 50 files that are larger than 10 KB:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 To exclude a specific file from indexing and add it to the ignored file list:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 To see all the files that aren't indexed:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 To clear previously indexed data and restart indexing:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 To save all changeset history:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 To remove the size limit on CodeLens temporary data and continue indexing regardless of temporary data size:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 To delete the code index with confirmation:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## See Also  
 [Managing server configuration with TFSConfig](assetId:///94424190-3b6b-4f33-a6b6-5807f4225b62)   
 [Command-line tools for TFS](assetId:///be8c997a-b97b-4e59-97f5-04db0a601a6c)