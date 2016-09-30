---
title: "Testing the Read-Only Provider"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "testing, OLE DB providers"
  - "testing providers"
  - "OLE DB providers, calling"
  - "OLE DB providers, testing"
ms.assetid: e4aa30c1-391b-41f8-ac73-5270e46fd712
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Testing the Read-Only Provider
To test a provider, you need a consumer. It helps if the consumer can match up with the provider. The OLE DB consumer templates are a thin wrapper around OLE DB and match with the provider COM objects. Because the source is shipped with the consumer templates, it is easy to debug a provider with them. The consumer templates are also a very small and fast way to develop consumer applications.  
  
 The example in this topic creates a default MFC Application Wizard application for a test consumer. The test application is a simple dialog with OLE DB consumer template code added.  
  
### To create the test application  
  
1.  On the **File** menu, click **New**, and then click **Project**.  
  
2.  In the Project Types pane, select the **Visual C++ Projects** folder. In the Templates pane, select **MFC Application**.  
  
3.  For the project name, enter **TestProv**, and then click **OK**.  
  
     The MFC Application Wizard appears.  
  
4.  On the **Application Type** page, select **Dialog based**.  
  
5.  On the **Advanced Features** page, select **Automation**, and then click **Finish**.  
  
> [!NOTE]
>  The application does not require Automation support if you add **CoInitialize** in **CTestProvApp::InitInstance**.  
  
 You can view and edit the TestProv dialog box (IDD_TESTPROV_DIALOG) by selecting it in Resource View. Place two list boxes, one for each string in the rowset, in the dialog box. Turn off the sort property for both list boxes by pressing ALT+Enter when a list box is selected, clicking the **Styles** tab, and clearing the **Sort** check box. Also, place a **Run** button on the dialog box to fetch the file. The finished TestProv dialog box should have two list boxes labeled "String 1" and "String 2", respectively; it also has **OK**, **Cancel**, and **Run** buttons.  
  
 Open the header file for the dialog class (in this case TestProvDlg.h). Add the following code to the header file (outside of any class declarations):  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The code represents a user record that defines what columns will be in the rowset. When the client calls **IAccessor::CreateAccessor**, it uses these entries to specify which columns to bind. The OLE DB consumer templates also allow you to bind columns dynamically. The COLUMN_ENTRY macros are the client-side version of the PROVIDER_COLUMN_ENTRY macros. The two COLUMN_ENTRY macros specify the ordinal, type, length, and data member for the two strings.  
  
 Add a handler function for the **Run** button by pressing CTRL and double-clicking the **Run** button. Place the following code in the function:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> classes all belong to the OLE DB consumer templates. Each class mimics a COM object in the provider. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object takes the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class, declared in the header file, as a template parameter. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter represents bindings that you use to access the data from the provider. Here is the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> code for the data source, session, and command:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The lines to open each of the classes create each COM object in the provider. To locate the provider, use the ProgID of the provider. You can get the ProgID from the system registry or by looking in the MyProvider.rgs file (open the provider's directory and search for the ProgID key).  
  
 The MyData.txt file is included with the MyProv sample. To create a file of your own, use an editor and type an even number of strings, pressing ENTER between each string. Change the path name if you move the file.  
  
 Pass in the string "c:\\\samples\\\myprov\\\MyData.txt" in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> line. If you step into the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> call, you see that this string is passed to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method in the provider. Note that the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method used that string.  
  
 To fetch the data, call <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> on the table. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> calls the **IRowset::GetNextRows**, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> functions. When there are no more rows (that is, the current position in the rowset is greater than <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>), the loop terminates:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Note that when there are no more rows, providers return **DB_S_ENDOFROWSET**. The **DB_S_ENDOFROWSET** value is not an error. You should always check against <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to cancel a data fetch loop and not use the SUCCEEDED macro.  
  
 You should now be able to build and test the program.  
  
## See Also  
 [Enhancing the Simple Read-Only Provider](../vs140/enhancing-the-simple-read-only-provider.md)