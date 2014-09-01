function displayProperties() {
    var properties = [];
    for (var prop in document) {
        properties.push(prop);
    }

    properties.sort();

    return properties;
}

console.log(displayProperties(document).join("\n"));