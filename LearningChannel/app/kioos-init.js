	// Initialise the Kioos JavaScript SDK
	var kioosCallbacks = window.kioosCallbacks || [];
	kioosCallbacks.push(function() {
		Kioos.init({
			key: 'dad6d0c20d404d1fab5b2ed1be5d6008',	// Insert here your JavaScript API key
			site: 'izzui.com',		// Insert here the Site URL to use
			playerUuid: '0001',			// This is the Unique Identifier for the current player
			lang: 'pt'					// Localisation settings. Currently supported: pt (Portuguese) and en (English)
		});
	});
	
	// Load the Kioos JavaScript SDK Asynchronously
	// Note: the default script is bundled with jQuery. If jQuery is
	// already available, then set the function flag to false.
	(function( jqueryVersion ) {
		var script = document.createElement('script');
		var entry = document.getElementsByTagName('script')[0];
		script.async = true;
		script.src = '//s3.amazonaws.com/kioos-widgets/v1/kioos' + (jqueryVersion ? '.jquery' : '') + '.min.js';
		entry.parentNode.insertBefore(script, entry);
	}( true ));