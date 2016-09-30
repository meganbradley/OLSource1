---
title: "TN022: Standard Commands Implementation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.commands"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ID_PREV_PANE command"
  - "ID_APP_EXIT command"
  - "ID_NEXT_PANE command"
  - "ID_INDICATOR_REC command"
  - "ID_WINDOW_SPLIT command"
  - "ID_FILE_PRINT_PREVIEW command"
  - "ID_WINDOW_CASCADE command"
  - "ID_FILE_CLOSE command"
  - "ID_FILE_SAVE_COPY_AS command"
  - "ID_WINDOW_ARRANGE command"
  - "ID_EDIT_FIND command"
  - "ID_FILE_OPEN command"
  - "ID_FILE_PAGE_SETUP command"
  - "ID_OLE_VERB_FIRST command"
  - "ID_EDIT_UNDO command"
  - "ID_EDIT_CLEAR command"
  - "ID_INDICATOR_CAPS command"
  - "ID_HELP_INDEX command"
  - "commands, standard"
  - "ID_FILE_PRINT_SETUP command"
  - "ID_DEFAULT_HELP command"
  - "ID_INDICATOR_SCRL command"
  - "ID_FILE_PRINT command"
  - "ID_INDICATOR_OVR command"
  - "ID_INDICATOR_KANA command"
  - "ID_EDIT_COPY command"
  - "ID_EDIT_REDO command"
  - "ID_EDIT_PASTE command"
  - "ID_OLE_INSERT_NEW command"
  - "ID_OLE_EDIT_LINKS command"
  - "ID_EDIT_PASTE_SPECIAL command"
  - "ID_INDICATOR_EXT command"
  - "ID_HELP_USING command"
  - "standard commands"
  - "ID_VIEW_STATUS_BAR command"
  - "ID_FILE_SAVE_AS command"
  - "ID_EDIT_CLEAR_ALL command"
  - "ID_WINDOW_NEW command"
  - "ID_CONTEXT_HELP command"
  - "ID_EDIT_REPLACE command"
  - "ID_WINDOW_TILE_HORZ command"
  - "ID_APP_ABOUT command"
  - "TN022"
  - "ID_VIEW_TOOLBAR command"
  - "ID_HELP command"
  - "ID_WINDOW_TILE_VERT command"
  - "ID_EDIT_CUT command"
  - "ID_FILE_UPDATE command"
  - "ID_EDIT_REPEAT command"
  - "ID_FILE_SAVE command"
  - "ID_EDIT_PASTE_LINK command"
  - "ID_EDIT_SELECT_ALL command"
  - "ID_FILE_NEW command"
  - "ID_INDICATOR_NUM command"
ms.assetid: a7883b46-23f7-4870-ac3a-804aed9258b5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN022: Standard Commands Implementation
> [!NOTE]
>  The following technical note has not been updated since it was first included in the online documentation. As a result, some procedures and topics might be out of date or incorrect. For the latest information, it is recommended that you search for the topic of interest in the online documentation index.  
  
 This note describes the standard command implementations provided by MFC 2.0. Read [Technical Note 21](../vs140/tn021--command-and-message-routing.md) first because it describes the mechanisms used to implement many of the standard commands.  
  
 This description assumes knowledge of the MFC architectures, APIs, and common programming practice. Documented as well as undocumented "implementation only" APIs are described. This is not a place to start learning about the features of or how to program in MFC. Refer to Visual C++ for more general information and for details of documented APIs.  
  
## The Problem  
 MFC defines many standard command IDs in the header file AFXRES.H. Framework support for these commands varies. Understanding where and how the framework classes handle these commands will not only show you how the framework works internally but will provide useful information on how to customize the standard implementations and teach you a few techniques for implementing your own command handlers.  
  
## Contents of This Technical Note  
 Each command ID is described in two sections:  
  
-   The title: the symbolic name of the command ID (for example, **ID_FILE_SAVE**) followed by the purpose of the command (for example, "saves the current document") separated by a colon.  
  
-   One or more paragraphs describing which classes implement the command, and what the default implementation does  
  
 Most default command implementations are prewired in the framework's base class message map. There are some command implementations that require explicit wiring in your derived class. These are described under "Note". If you chose the right options in AppWizard, these default handlers will be connected for you in the generated skeleton application.  
  
## Naming Convention  
 Standard commands follow a simple naming convention that we recommend you use if possible. Most standard commands are located in standard places in an application's menu bar. The symbolic name of the command starts with "ID_" followed by the standard pop-up menu name, followed by the menu item name. The symbolic name is in upper case with underscore word-breaks. For commands that do not have standard menu item names, a logical command name is defined starting with "ID_" (for example, **ID_NEXT_PANE**).  
  
 We use the prefix "ID_" to indicate commands that are designed to be bound to menu items, toolbar buttons, or other command user-interface objects. Command handlers handling "ID_" commands should use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> mechanisms of the MFC command architecture.  
  
 We recommend you use the standard "IDM_" prefix for menu items which do not follow the command architecture and need menu-specific code to enable and disable them. Of course the number of menu specific commands should be small since following the MFC command architecture not only makes command handlers more powerful (since they will work with toolbars) but makes the command handler code reusable.  
  
## ID Ranges  
 Please refer to [Technical Note 20](../vs140/tn020--id-naming-and-numbering-conventions.md) for more details on the use of ID ranges in MFC.  
  
 MFC standard commands fall in the range 0xE000 to 0xEFFF. Please do not rely on the specific values of these IDs since they are subject to change in future versions of the library.  
  
 Your application should define its commands in the range 0x8000 to 0xDFFF.  
  
## Standard Command IDs  
 For each command ID, there is a standard message line prompt string that can be found in the file PROMPTS.RC. The string ID for that menu prompt must be the same as for the command ID.  
  
-   ID_FILE_NEW   Creates a new/empty document.  
  
    > [!NOTE]
    >  You must connect this to your <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived class's message map to enable this functionality.  
  
     <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> implements this command differently depending on the number of document templates in the application. If there is only one <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will create a new document of that type, as well as the proper frame and view class.  
  
     If there is more than one <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> will prompt the user with a dialog (**AFX_IDD_NEWTYPEDLG**) letting them select which document type to use. The selected <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is used to create the document.  
  
     One common customization of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is to provide a different and more graphical choice of document types. In this case you can implement your own **CMyApp::OnFileNew** and place it in your message map instead of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. There is no need to call the base class implementation.  
  
     Another common customization of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is to provide a separate command for creating a document of each type. In this case you should define new command IDs, for example ID_FILE_NEW_CHART and ID_FILE_NEW_SHEET.  
  
-   ID_FILE_OPEN   Opens an existing document.  
  
    > [!NOTE]
    >  You must connect this to your <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>-derived class's message map to enable this functionality.  
  
     <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> has a very simple implementation of calling **CWinApp::DoPromptFileName** followed by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> with the file or path name of the file to open. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> implementation routine **DoPromptFileName** brings up the standard FileOpen dialog and fills it with the file extensions obtained from the current document templates.  
  
     One common customization of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is to customize the FileOpen dialog or add additional file filters. The recommended way to customize this is to replace the default implementation with your own FileOpen dialog, and call <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> with the document's file or path name. There is no need to call the base class.  
  
-   ID_FILE_CLOSE   Closes the currently open document.  
  
     **CDocument::OnFileClose** calls <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to prompt the user to save the document if it has been modified and then calls <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. All the closing logic, including destroying the document, is done in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> routine.  
  
    > [!NOTE]
    >  **ID_FILE_CLOSE** acts differently from a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> message or an **SC_CLOSE** system command sent to the documents frame window. Closing a window will close the document only if that is the last frame window showing the document. Closing the document with **ID_FILE_CLOSE** will not only close the document but will close down all frame windows showing the document.  
  
-   ID_FILE_SAVE   Saves the current document.  
  
     The implementation uses a helper routine **CDocument::DoSave** which is used for both **OnFileSave** and **OnFileSaveAs**. If you save a document that has not been saved before (that is, it does not have a path name, as in the case of FileNew) or that was read from a read-only document, the **OnFileSave** logic will act like the **ID_FILE_SAVE_AS** command and ask the user to provide a new file name. The actual process of opening the file and doing the saving is done through the virtual function <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
     There are two common reasons to customize **ID_FILE_SAVE**. For documents that do not save, simply remove the **ID_FILE_SAVE** menu items and toolbar buttons from your user interface. Also make sure that you never dirty your document (that is, never call <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>) and the framework will never cause the document to be saved. For documents that save to someplace other than a disk file, define a new command for that operation.  
  
     In the case of a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, **ID_FILE_SAVE** is used both for file save (for normal documents) and file update (for embedded documents).  
  
     If your document data is stored in individual disk files, but you don't want to use the default **CDocument** serialize implementation, you should override <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> instead of **OnFileSave**.  
  
-   ID_FILE_SAVE_AS   Saves the current document under a different file name.  
  
     The **CDocument::OnFileSaveAs** implementation uses the same **CDocument::DoSave** helper routine as **OnFileSave**. The **OnFileSaveAs** command is handled just as **ID_FILE_SAVE** if the documents had no file name before the save. **COleServerDoc::OnFileSaveAs** implements the logic to save a normal document data file or to save a server document representing an OLE object embedded in some other application as a separate file.  
  
     If you customize the logic of **ID_FILE_SAVE**, you will probably want to customize **ID_FILE_SAVE_AS** in a similar fashion or the operation of "Save As" may not apply to your document. You can remove the menu item from your menu bar if it is not needed.  
  
-   ID_FILE_SAVE_COPY_AS   Saves a copy current document under a new name.  
  
     The **COleServerDoc::OnFileSaveCopyAs** implementation is very similar to **CDocument::OnFileSaveAs**, except that the document object is not "attached" to the underlying file after the save. That is, if the in-memory document was "modified" before the save, it is still "modified". In addition, this command has no effect on the path name or title stored in the document.  
  
-   ID_FILE_UPDATE   Notifies the container to save an embedded document.  
  
     The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> implementation simply notifiies the container that the embedding should be saved. The container then calls the appropriate OLE APIs in order to save the embedded object.  
  
-   ID_FILE_PAGE_SETUP   Invokes an application-specific page setup/layout dialog.  
  
     Currently there is no standard for this dialog, and the framework has no default implementation of this command.  
  
     If you choose to implement this command, we recommend you use this command ID.  
  
-   ID_FILE_PRINT_SETUP   Invoke the standard Print Setup dialog.  
  
    > [!NOTE]
    >  You must connect this to your <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>-derived class's message map to enable this functionality.  
  
     This command invokes the standard print setup dialog that allows the user to customize the printer and print settings for at least this document or at most all the documents in this application. You must use the Control Panel to change the default printer settings for the entire system.  
  
     <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> has a very simple implementation creating a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object and calling the **CWinApp::DoPrintDialog** implementation function. This sets the application default printer setup.  
  
     The common need for customizing this command is to allow for per-document printer settings, which should be stored with the document when saved. To do this you should add a message-map handler in your **CDocument** class that creates a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object, initializes it with the appropriate printer attributes (usually **hDevMode** and **hDevNames**), call the **CPrintDialog::DoModal,** and save the changed printer settings. For a robust implementation, you should look at the implementation of **CWinApp::DoPrintDialog** for detecting errors and **CWinApp::UpdatePrinterSelection** for dealing with sensible defaults and tracking system-wide printer changes.  
  
-   ID_FILE_PRINT   Standard printing of the current document  
  
    > [!NOTE]
    >  You must connect this to your <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>-derived class's message map to enable this functionality.  
  
     This command prints the current document, or more correctly, starts the printing process, which involves invoking the standard print dialog and running the print engine.  
  
     **CView::OnFilePrint** implements this command and the main print loop. It calls the virtual <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to prompt of the user with the print dialog. It then prepares the output DC to go to the printer, brings up the printing progress dialog (**AFX_IDD_PRINTDLG**), and sends the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> escape to the printer. **CView::OnFilePrint** also contains the main page-oriented print loop. For each page, it calls the virtual <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> followed by a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> escape and calling the virtual <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> for that page. When complete, the virtual <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is called, and the printing progress dialog is closed.  
  
     The MFC printing architecture is designed to hook in many different ways for printing and print preview. You will normally find the various <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> overridable functions adequate for any page-oriented printing tasks. Only in the case of an application that uses the printer for non-page oriented output, should you find the need to replace the **ID_FILE_PRINT** implementation.  
  
-   ID_FILE_PRINT_PREVIEW   Enter print-preview mode for the current document.  
  
    > [!NOTE]
    >  You must connect this to your <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>-derived class's message map to enable this functionality.  
  
     **CView::OnFilePrintPreview** starts the print preview mode by calling the documented helper function **CView::DoPrintPreview**. **CView::DoPrintPreview** is the main engine for the print preview loop, just as **OnFilePrint** is the main engine for the printing loop.  
  
     The print preview operation can be customized in a variety of ways by passing different parameters to **DoPrintPreview**. Please refer to [Technical Note 30](../vs140/tn030--customizing-printing-and-print-preview.md), which discusses some of the details of print preview and how to customize it.  
  
-   **ID_FILE_MRU_FILE1**...**FILE16** A range of command IDs for the File MRU <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
     **CWinApp::OnUpdateRecentFileMenu** is a update command UI handler that is one of the more advanced uses of the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> mechanism. In your menu resource, you need only define a single menu item with ID **ID_FILE_MRU_FILE1**. That menu item remains initially disabled.  
  
     As the MRU list grows, more menu items are added to the list. The standard <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> implementation defaults to the standard limit of the four most recently used files. You can change the default by calling <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> with a larger or smaller value. The MRU list is stored in the application's .INI file. The list is loaded in your application's <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> function if you call <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, and is saved when your application exits. The MRU update command UI handler also will convert absolute paths to relative paths for display on the file menu.  
  
     **CWinApp::OnOpenRecentFile** is the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> handler that performs the actual command. It simply gets the file name from the MRU list and calls <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, which does all the work of opening the file and updating the MRU list.  
  
     Customization of this command handler is not recommended.  
  
-   ID_EDIT_CLEAR   Clears the current selection  
  
     Currently there is no standard implementation for this command. You must implement this for each <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>-derived class.  
  
     <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> provides an implementation of this command using <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. The command is disabled if there is no current selection.  
  
     If you choose to implement this command, we recommend you use this command ID.  
  
-   ID_EDIT_CLEAR_ALL   Clears the entire document.  
  
     Currently there is no standard implementation for this command. You must implement this for each <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>-derived class.  
  
     If you choose to implement this command, we recommend you use this command ID. See the MFC Tutorial sample [SCRIBBLE](../vs140/visual-c---samples.md) for an example implementation.  
  
-   ID_EDIT_COPY   Copies the current selection to the Clipboard.  
  
     Currently there is no standard implementation for this command. You must implement this for each <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>-derived class.  
  
     <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> provides an implementation of this command, which copies the currently selected text to the Clipboard as CF_TEXT using <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. The command is disabled if there is no current selection.  
  
     If you choose to implement this command, we recommend you use this command ID.  
  
-   ID_EDIT_CUT   Cuts the current selection to the Clipboard.  
  
     Currently there is no standard implementation for this command. You must implement this for each <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>-derived class.  
  
     <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> provides an implementation of this command, which cuts the currently selected text to the Clipboard as CF_TEXT using <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. The command is disabled if there is no current selection.  
  
     If you choose to implement this command, we recommend you use this command ID.  
  
-   ID_EDIT_FIND   Begins the find operation, brings up the modeless find dialog.  
  
     Currently there is no standard implementation for this command. You must implement this for each <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>-derived class.  
  
     <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> provides an implementation of this command, which calls the implementation helper function **OnEditFindReplace** to use and store the previous find/replace settings in private implementation variables. The <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> class is used to manage the modeless dialog for prompting the user.  
  
     If you choose to implement this command, we recommend you use this command ID.  
  
-   ID_EDIT_PASTE   Inserts the current Clipboard contents.  
  
     Currently there is no standard implementation for this command. You must implement this for each <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>-derived class.  
  
     <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> provides an implementation of this command, which copies the current Clipboard data replacing the selected text using <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>. The command is disabled if there is no **CF_TEXT** in the Clipboard.  
  
     **COleClientDoc** just provides a update command UI handler for this command. If the Clipboard does not contain an embeddable OLE item/object, the command will be disabled. You are responsible for writing the handler for the actual command to do the actual pasting. If your OLE application can also paste other formats, you should provide your own update command UI handler in your view or document (that is, somewhere before **COleClientDoc** in the command target routing).  
  
     If you choose to implement this command, we recommend you use this command ID.  
  
     For replacing the standard OLE implementation, use <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
-   ID_EDIT_PASTE_LINK   Inserts a link from the current Clipboard contents.  
  
     Currently there is no standard implementation for this command. You must implement this for each <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>-derived class.  
  
     <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> just provides a update command UI handler for this command. If the Clipboard does not contain linkable OLE item/object, the command will be disabled. You are responsible for writing the handler for the actual command to do the actual pasting. If your OLE application can also paste other formats, you should provide your own update command UI handler in your view or document (that is, somewhere before <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> in the command target routing).  
  
     If you choose to implement this command, we recommend you use this command ID.  
  
     For replacing the standard OLE implementation, use <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
-   ID_EDIT_PASTE_SPECIAL   Inserts the current Clipboard contents with options.  
  
     Currently there is no standard implementation for this command. You must implement this for each <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>-derived class. MFC does not provide this dialog.  
  
     If you choose to implement this command, we recommend you use this command ID.  
  
-   ID_EDIT_REPEAT   Repeats the last operation.  
  
     Currently there is no standard implementation for this command. You must implement this for each <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>-derived class.  
  
     <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> provides an implementation of this command to repeat the last find operation. The private implementation variables for the last find are used. The command is disabled if a find cannot be attempted.  
  
     If you choose to implement this command, we recommend you use this command ID.  
  
-   ID_EDIT_REPLACE   Begins the replace operation, brings up the modeless replace dialog.  
  
     Currently there is no standard implementation for this command. You must implement this for each <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>-derived class.  
  
     <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> provides an implementation of this command, which calls the implementation helper function **OnEditFindReplace** to use and store the previous find/replace settings in private implementation variables. The <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> class is used to manage the modeless dialog that prompts the user.  
  
     If you choose to implement this command, we recommend you use this command ID.  
  
-   ID_EDIT_SELECT_ALL   Selects the entire document.  
  
     Currently there is no standard implementation for this command. You must implement this for each <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>-derived class.  
  
     <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> provides an implementation of this command, which selects all the text in the document. The command is disabled if there is no text to select.  
  
     If you choose to implement this command, we recommend you use this command ID.  
  
-   ID_EDIT_UNDO   Undoes the last operation.  
  
     Currently there is no standard implementation for this command. You must implement this for each <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>-derived class.  
  
     <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> provides an implementation of this command, using <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>. The command is disabled if <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> returns FALSE.  
  
     If you choose to implement this command, we recommend you use this command ID.  
  
-   ID_EDIT_REDO   Redoes the last operation.  
  
     Currently there is no standard implementation for this command. You must implement this for each <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>-derived class.  
  
     If you choose to implement this command, we recommend you use this command ID.  
  
-   ID_WINDOW_NEW   Opens another window on the active document.  
  
     **CMDIFrameWnd::OnWindowNew** implements this powerful feature by using the document template of the current document to create another frame containing another view of the current document.  
  
     Like most multiple document interface (MDI) Window menu commands, the command is disabled if there is no active MDI child window.  
  
     Customization of this command handler is not recommended. If you wish to provide a command that creates additional views or frame windows, you will probably be better off inventing your own command. You can clone the code from **CMDIFrameWnd::OnWindowNew** and modify it to the specific frame and view classes of your liking.  
  
-   ID_WINDOW_ARRANGE   Arranges icons at the bottom of an MDI window.  
  
     <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> implements this standard MDI command in an implementation helper function **OnMDIWindowCmd**. This helper maps command IDs to MDI Windows messages and can therefore share a lot of code.  
  
     Like most MDI Window menu commands, the command is disabled if there is no active MDI child window.  
  
     Customization of this command handler is not recommended.  
  
-   ID_WINDOW_CASCADE   Cascades windows so they overlap.  
  
     <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> implements this standard MDI command in an implementation helper function **OnMDIWindowCmd**. This helper maps command IDs to MDI Windows messages and can therefore share a lot of code.  
  
     Like most MDI Window menu commands, the command is disabled if there is no active MDI child window.  
  
     Customization of this command handler is not recommended.  
  
-   ID_WINDOW_TILE_HORZ   Tiles windows horizontally.  
  
     This command is implemented in <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> just like **ID_WINDOW_CASCADE**, except a different MDI Windows message is used for the operation.  
  
     You should pick the default tile orientation for your application. You can do this by changing the ID for the Window "Tile" menu item to either **ID_WINDOW_TILE_HORZ** or **ID_WINDOW_TILE_VERT**.  
  
-   ID_WINDOW_TILE_VERT   Tiles windows vertically.  
  
     This command is implemented in <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> just like **ID_WINDOW_CASCADE**, except a different MDI Windows message is used for the operation.  
  
     You should pick the default tile orientation for your application. You can do this by changing the ID for the Window "Tile" menu item to either **ID_WINDOW_TILE_HORZ** or **ID_WINDOW_TILE_VERT**.  
  
-   ID_WINDOW_SPLIT   Keyboard interface to splitter.  
  
     <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> handles this command for the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> implementation. If the view is part of a splitter window, this command will delegate to the implementation function <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>. This will place the splitter in a mode that will allow keyboard users to split or unsplit a splitter window.  
  
     This command is disabled if the view is not in a splitter.  
  
     Customization of this command handler is not recommended.  
  
-   ID_APP_ABOUT   Invokes the About dialog box.  
  
     There is no standard implementation for an application's About box. The default AppWizard-created application will create a custom dialog class for your application and use it as your About box. AppWizard will also write the trivial command handler which handles this command and invokes the dialog.  
  
     You will almost always implement this command.  
  
-   ID_APP_EXIT   Exit the application.  
  
     **CWinApp::OnAppExit** handles this command by sending a <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> message to the application's main window. The standard shutting down of the application (prompting for dirty files and so on) is handled by the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> implementation.  
  
     Customization of this command handler is not recommended. Overriding <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> or the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> closing logic is recommended.  
  
     If you choose to implement this command, we recommend you use this command ID.  
  
-   ID_HELP_INDEX   Lists Help topics from .HLP file.  
  
    > [!NOTE]
    >  You must connect this to your <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>-derived class's message map to enable this functionality.  
  
     <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> handles this command by trivially calling <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.  
  
     Customization of this command handler is not recommended.  
  
-   ID_HELP_USING   Displays help on how to use Help.  
  
    > [!NOTE]
    >  You must connect this to your <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>-derived class's message map to enable this functionality.  
  
     <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> handles this command by trivially calling <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
     Customization of this command handler is not recommended.  
  
-   ID_CONTEXT_HELP   Enters SHIFT-F1 help mode.  
  
    > [!NOTE]
    >  You must connect this to your <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>-derived class's message map to enable this functionality.  
  
     <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> handles this command by setting the help mode cursor, entering a modal loop and waiting for the user to select a window to get help on. Please refer to [Technical Note 28](../vs140/tn028--context-sensitive-help-support.md) for more details on the MFC Help implementation.  
  
     Customization of this command handler is not recommended.  
  
-   ID_HELP   Gives help on the current context  
  
    > [!NOTE]
    >  You must connect this to your <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>-derived class's message map to enable this functionality.  
  
     <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> handles this command by getting the right help context for the current application context. This handles simple F1 help, help on message boxes and so on. Please refer to [Technical Note 28](../vs140/tn028--context-sensitive-help-support.md) for more details on the MFC help implementation.  
  
     Customization of this command handler is not recommended.  
  
-   ID_DEFAULT_HELP   Displays default help for context  
  
    > [!NOTE]
    >  You must connect this to your <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>-derived class's message map to enable this functionality.  
  
     This command is usually mapped to <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.  
  
     A different command handler can be provided if a distinction between default Help and the Help index is desired.  
  
-   ID_NEXT_PANE   Goes to next pane  
  
     <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> handles this command for the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> implementation. If the view is part of a splitter window, this command will delegate to the implementation function **CSplitterWnd::OnNextPaneCmd**. This will move the active view to the next pane in the splitter.  
  
     This command is disabled if the view is not in a splitter or there is no next pane to go to.  
  
     Customization of this command handler is not recommended.  
  
-   ID_PREV_PANE   Goes to previous pane  
  
     <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> handles this command for the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> implementation. If the view is part of a splitter window, this command will delegate to the implementation function **CSplitterWnd::OnNextPaneCmd**. This will move the active view to the previous pane in the splitter.  
  
     This command is disabled if the view is not in a splitter or there is no previous pane to go to.  
  
     Customization of this command handler is not recommended.  
  
-   ID_OLE_INSERT_NEW   Inserts a new OLE object  
  
     Currently there is no standard implementation for this command. You must implement this for your <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>-derived class to insert a new OLE item/object at the current selection.  
  
     All OLE client applications should implement this command. AppWizard, with the OLE option, will create a skeleton implementation of **OnInsertObject** in your view class that you will have to complete.  
  
     See the MFC OLE sample [OCLIENT](../vs140/visual-c---samples.md) example for a complete implementation of this command.  
  
-   ID_OLE_EDIT_LINKS   Edits OLE links  
  
     <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> handles this command by using the MFC-provided implementation of the standard OLE links dialog. The implementation of this dialog is accessed through the <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> class. If the current document does not contain any links, the command is disabled.  
  
     Customization of this command handler is not recommended.  
  
-   ID_OLE_VERB_FIRST...LAST   An ID range for OLE verbs  
  
     <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> uses this command ID range for the verbs supported by the currently selected OLE item/object. This must be a range since a given OLE item/object type can support zero or more custom verbs. In your application's menu, you should have one menu item with the ID of **ID_OLE_VERB_FIRST**. When the program is run, the menu will be updated with the appropriate menu verb description (or pop-up menu with many verbs). The management of the OLE menu is handled by <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>, done in the update command UI handler for this command.  
  
     There are no explicit command handlers for handling each of the command ID in this range. **COleDocument::OnCmdMsg** is overridden to trap all command IDs in this range, turn them into zero-based verb numbers, and launch the server for that verb (using <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>).  
  
     Customization or other use of this command ID range is not recommended.  
  
-   ID_VIEW_TOOLBAR   Toggles the toolbar on and off  
  
     <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> handles this command and the update-command UI handler to toggle the visible state of the toolbar. The toolbar must be a child window of the frame with child window ID of <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>. The command handler actually toggles the visibility of the toolbar window. <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> is used to redraw the frame window with the toolbar in its new state. The update-command UI handler checks the menu item when the toolbar is visible.  
  
     Customization of this command handler is not recommended. If you wish to add additional toolbars, you will want to clone and modify the command handler and the update-command UI handler for this command.  
  
-   ID_VIEW_STATUS_BAR   Toggles the status bar on and off  
  
     This command is implemented in <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> just like **ID_VIEW_TOOLBAR**, except a different child window ID (**AFX_IDW_STATUS_BAR**) is used.  
  
## Update-Only Command Handlers  
 Several standard command IDs are used as indicators in status bars. These use the same update-command UI handling mechanism to display their current visual state during application idle time. Since they can't be selected by the user (that is, you cannot push a status bar pane), then it makes no sense to have an <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> handler for these command IDs.  
  
-   **ID_INDICATOR_CAPS** : CAP lock indicator.  
  
-   **ID_INDICATOR_NUM** : NUM lock indicator.  
  
-   **ID_INDICATOR_SCRL** : SCRL lock indicator.  
  
-   **ID_INDICATOR_KANA** : KANA lock indicator (applicable only to Japanese systems).  
  
 All three of these are implemented in **CFrameWnd::OnUpdateKeyIndicator**, an implementation helper that uses the command ID to map to the appropriate Virtual Key. A common implementation enables or disables (for status panes disabled = no text) the <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> object depending on whether the appropriate Virtual Key is currently locked.  
  
 Customization of this command handler is not recommended.  
  
-   **ID_INDICATOR_EXT : EXT**ended select indicator.  
  
-   **ID_INDICATOR_OVR : OV**e**R**strike indicator.  
  
-   **ID_INDICATOR_REC : REC**ording indicator.  
  
 Currently there is no standard implementation for these indicators.  
  
 If you choose to implement these indicators, we recommend you use these indicator IDs and maintaining the ordering of the indicators in your status bar (that is, in this order: EXT, CAP, NUM, SCRL, OVR, REC).  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)