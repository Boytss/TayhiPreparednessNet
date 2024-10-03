// script.ts
// Define JavaScript function to send message
function showAllEvacuees() {
    // Send a message to the WinForms application
    window.chrome.webview.postMessage('ShowAllEvacuees');
}
