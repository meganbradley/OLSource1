---
title: "Walkthrough: Creating a Report"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 6f7b57fa-aa0a-448b-ba1e-9819d38e2e88
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Creating a Report
[!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] doesn’t have built-in reporting capabilities, but you can create and print reports from a [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] application by integrating Word. You can automate reporting by using Visual Studio and APIs for Word, but the Office Integration Pack [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] extension simplifies the task.  
  
 By using the Office Integration Pack, you can more easily automate [!INCLUDE[Word_14_short](../vs140/includes/word_14_short_md.md)], [!INCLUDE[Excel_14_short](../vs140/includes/excel_14_short_md.md)], and [!INCLUDE[Outlook_14_short](../vs140/includes/outlook_14_short_md.md)] in a variety of ways. For example, you can import and export data, create documents and reports, and work with email and appointments. You can download the Office Integration Pack extension for free from CodePlex.  
  
## Prerequisites  
 This walkthrough requires the following components:  
  
-   [Office Integration Pack](http://go.microsoft.com/fwlink/?LinkId=261875)  
  
-   [Vision Clinic sample application](http://go.microsoft.com/fwlink/?LinkId=261876)  
  
## Create the Report Template  
 First, you create a Word document that will serve as a template for the report.  
  
#### To create the report template  
  
1.  Open [!INCLUDE[Word_14_short](../vs140/includes/word_14_short_md.md)].  
  
     A new blank document appears.  
  
2.  At the top of the document, type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
3.  Highlight the text, and then, in the **Styles** group of the **Home** tab on the ribbon, choose the **Title** command.  
  
4.  Move the cursor below the title, and then, on the **Insert** tab, choose the **Table** command, and then choose the **Insert Table** command.  
  
     The **Insert Table** dialog box appears.  
  
5.  In the **Number of columns** text box, enter <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and then, in the **Number of rows** text box, enter <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
6.  Choose the **AutoFit to Window** option button, and then choose the **OK** button.  
  
7.  In the first row of the table, enter the following column headings: <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
8.  Highlight the table, and then, in the **Links** group of the **Insert** tab, choose the **Bookmark** command.  
  
9. In the **Bookmark** dialog box, name the bookmark **Catalog**, and then choose the **Add** button.  
  
10. In the **Page Setup** group of the **Page Layout** tab, choose the **Orientation** command, and then choose the **Landscape** command.  
  
11. On the **File** tab, choose the **Save As** command.  
  
12. In the **Save As** dialog box, open the **My Documents** folder, name the file <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and then choose the **Save** button.  
  
13. On the **File** tab, choose the **Exit** command.  
  
## Add a Report to the Application  
 After you create the report template, you enable the Office Integration Pack extension, add a button to the application toolbar, and add code to create the report. You can also change the document type.  
  
> [!NOTE]
>  If you haven’t previously built the Vision Clinic sample application, you'll first need to install and configure the PrescriptionContoso database, which is downloaded as part of the sample package. Open the Install.htm file, and then follow the instructions to install the database.  
  
#### To enable the extension  
  
1.  On the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] menu bar, choose **File**, **Open**, **Project/Solution**.  
  
2.  Locate the **Vision Clinic.sln** file, and then choose the **Open** button.  
  
3.  In **Solution Explorer**, open the shortcut menu for the **Properties** node, and then choose **Open**.  
  
4.  In the application designer, choose the **Extensions** tab, and then select the **Office Integration Pack** check box.  
  
#### To create the report  
  
1.  In **Solution Explorer**, open the shortcut menu for the **ProductList** screen node, and then choose **Open**.  
  
2.  In the content tree pane, expand the **Screen Command Bar** node, and then choose **Add**, **New Button**.  
  
3.  In the **Add Button** dialog box, name the button that you're creating <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and then choose the **OK** button.  
  
4.  Open the shortcut menu for the **Catalog** button, and then choose **Edit Execute Code**.  
  
5.  In the **Code Editor**, enter the following Imports or using statement at the top of the file:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
6.  Add the following code to the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
7.  On the menu bar, choose **Debug**, **Start Debugging** to run the application.  
  
8.  On the **Tasks** menu, choose **Product List**, and then choose the **Catalog** button to view the report.  
  
9. (Optional) Add the following line of code to the end of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method to save and view the report in a .pdf format:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Next Steps  
 Explore the APIs in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> namespace to discover many more things that you can do by using the Office Integration Pack.  
  
## See Also  
 [Reporting and Printing in LightSwitch](../vs140/reporting-and-printing-in-lightswitch.md)