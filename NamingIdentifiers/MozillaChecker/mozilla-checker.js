(function () {
    function alertIsMozilla() {
        var targetBrowser = 'Mozilla',
            myWindow = window,
            currentBrowser = myWindow.navigator.appCodeName,
            isMozilla = (currentBrowser === targetBrowser),
            message;

        if (isMozilla) {
            message = 'Yes';
        } else {
            message = 'No';
        }

        alert(message);
    }

    alertIsMozilla();
}());
