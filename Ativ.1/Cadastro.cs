/*Atividade 1 - Luis Gustavo Correa Resende
 * Data: 07/10/2022
 * Cadastro: Declaração da classe para utilização forms2 */
public class Cadastro //metodo construtor
{
    public string estado;
    public string cidade;
    public string rua;
    public string cep;
    public string profissao;
    public float salario;
    public string est_civil;

    public Cadastro()
    {
        estado = "";
        cidade = "";
        rua = "";
        cep = "";
        profissao = "";
        salario = 0;
        est_civil = "";
    }  // metodo construtor 2


    public Cadastro(string p1_estado, string p1_cidade, string p1_rua, string p1_cep, string p1_profissao, float p1_salario, string p1_est_civil)
    {
        this.estado = p1_estado;
        this.cidade = p1_cidade;
        this.rua = p1_rua;
        this.cep = p1_cep;
        this.profissao = p1_profissao;
        this.salario = p1_salario;
        this.est_civil = p1_est_civil;
    }


    public string getestado()
    {
        return this.estado;
    }

    public void setestado(string p_estado)
    {
        this.estado = p_estado;
    }

    public string getcidade()
    {
        return this.cidade;
    }

    public void setcidade(string p_cidade)
    {
        this.cidade = p_cidade;
    }

    public string getrua()
    {
        return this.rua;
    }

    public void setrua(string p_rua)
    {
        this.rua = p_rua;
    }

    public string getcep()
    {
        return this.cep;
    }

    public void setcep(string p_cep)
    {
        this.cep = p_cep;
    }

    public string getprofissao()
    {
        return this.profissao;
    }

    public void setprofisssao(string p_profissao)
    {
        this.profissao = p_profissao;
    }

    public float getsalario()
    {
        return this.salario;
    }

    public void setsalario(float p_salario)
    {
        this.salario = p_salario;
    }

    public string getest_civil()
    {
        return this.est_civil;
    }

    public void setest_civil(string p_est_civil)
    {
        this.est_civil = p_est_civil;
    }

}
