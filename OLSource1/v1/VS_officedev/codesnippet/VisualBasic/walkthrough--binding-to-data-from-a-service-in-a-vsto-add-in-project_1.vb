    Private request As ContentService.getContentRequest
    Private proxy As ContentService.ContentServicePortTypeClient
    Private document As ContentService.requestedDocument()
    Private response As ContentService.getContentResponse
    Private appId As ContentService.appId
    Private WithEvents richTextContentControl As Microsoft.Office.Tools.Word.RichTextContentControl
    Private components As System.ComponentModel.Container
    Private primaryDocumentsBindingSource As System.Windows.Forms.BindingSource