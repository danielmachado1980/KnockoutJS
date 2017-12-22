function UsuarioViewModel() {
    this.Nome = ko.observable("");
    this.Email = ko.observable("");
    this.Senha = ko.observable("");

    var Usuario = {
        Nome: this.Nome,
        Email: this.Email,
        Senha: this.Senha
    };

    this.Usuario = ko.observable();

    //Add novo usuário
    self.create = function () {
        if (Usuario.Nome() != "" &&
            Usuario.Email() != "" && Usuario.Senha() != "") {
            $.ajax({
                url: 'Conta/Cadastrar',
                cache: false,
                type: 'POST',
                contentType: 'application/json; charset=utf-8',
                data: ko.toJSON(Usuario),
                success: function (data) {
                    this.Nome("");
                    this.Email("");
                    this.Senha("");
                }
            }).fail(
                function (xhr, textStatus, err) {
                    alert(err);
                });
        }
        else {
            alert('Por favor preencha todos os campos.');
        }
    }
}

$(document).ready(function () {
    // Activates knockout.js
    ko.applyBindings(new UsuarioViewModel());
});