var model = {
    view: ko.observable("welcome"),
    rsvp: {
        nama: ko.observable(""),
        alamat: "",
        umur: ko.observable("")
    },
    attendees: ko.observableArray([])
}
var showForm = function () {
    model.view("form");
}
var sendRsvp = function () {
    $.ajax("/api/rsvp", {
        type: "POST",
        data: {
            nama: model.rsvp.nama(),
            alamat: model.rsvp.alamat,
            umur: model.rsvp.umur()
        },
        success: function () {
            getAttendees();
        }
    });
}
var getAttendees = function () {
    $.ajax("/api/rsvp", {
        type: "GET",
        success: function (data) {
            model.attendees.removeAll();
            model.attendees.push.apply(model.attendees, data.map(function (rsvp) {
                return rsvp.Name;
            }));
            model.view("thanks");
        }
    });
}
$(document).ready(function () {
    ko.applyBindings();
})