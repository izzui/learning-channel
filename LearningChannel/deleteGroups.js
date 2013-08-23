var request = require('superagent');
request.get('https://graph.facebook.com/212553442202383/groups?access_token=212553442202383|zIGD114FUd3RihFP8ENA14NlsZE')
	.end(function(res) {
		var groups = JSON.parse(res.text).data;
		for (i in groups) {
			var group = groups[i];
			deleteGroup(group);
		}		
	});

var deleteGroup = function(group) {
	console.log('Deleting group "' + group.name + '"');
	request.del('https://graph.facebook.com/212553442202383/groups/' + group.id + '?access_token=212553442202383|zIGD114FUd3RihFP8ENA14NlsZE')
		.end(function(res) {
			if (res.text == "true") {
				console.log('Group "' + group.name + '" deleted.');
			}
			else {
				console.log('Error on deleting group "' + group.name + '"')
				console.log(res.text);
			}
		});

}