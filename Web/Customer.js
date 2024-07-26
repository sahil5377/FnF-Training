class Customer {
    constructor(id, name, address) {
        this.CustomerId = id;
        this.CustomerName = name;
        this.CustomerAddress = address;
    }
}

class CustomerRepo {
    constructor() {
        this.customerData = [
            new Customer(1, "Phaniraj", "Bangalore"),
            new Customer(2, "John Doe", "New York"),
            new Customer(3, "Jane Smith", "Los Angeles"),
            new Customer(4, "Alice Johnson", "Chicago")
        ];
    }

    addCustomer(cst) {
        this.customerData.push(cst);
    }

    getAll() {
        return this.customerData;
    }

    findCustomer(id) {
        return this.customerData.find(c => c.CustomerId == id);
    }

    findAllCustomers(name) {
        return this.customerData.filter(c => c.CustomerName.includes(name));
    }

    updateCustomer(cst) {
        const index = this.customerData.findIndex(c => c.CustomerId == cst.CustomerId);
        if (index < 0) {
            alert("No record found to update");
            return;
        }
        this.customerData.splice(index, 1, cst);
        alert("Customer updated successfully");
    }

    deleteCustomer(id) {
        const index = this.customerData.findIndex(c => c.CustomerId == id);
        if (index < 0) {
            alert("No record found to delete");
            return;
        }
        this.customerData.splice(index, 1);
        alert("Customer deleted successfully");
    }
}

const repo = new CustomerRepo();

function createRow(customer) {
    return `
        <tr data-id="${customer.CustomerId}">
            <td>${customer.CustomerId}</td>
            <td>${customer.CustomerName}</td>
            <td>${customer.CustomerAddress}</td>
            <td>
                <a class='btn btn-primary btn-edit'>Edit</a>
                <a class='btn btn-danger btn-delete'>Delete</a>
            </td>
        </tr>
    `;
}

function onUpdate() {
    const id = $("#cstId").val();
    const name = $("#cstName").val();
    const address = $("#cstAddress").val();
    const cust = new Customer(id, name, address);
    const isEditing = $("#cstId").attr("disabled") === "disabled";

    if (isEditing) {
        repo.updateCustomer(cust);
    } else {
        repo.addCustomer(cust);
    }

    $("#cstId").attr("disabled", false);
    $("section").hide();
    populateCustomers();
}

function fillData(data) {
    $("table tbody").empty();
    $.each(data, (index, element) => {
        let row = createRow(element);
        $("table tbody").append(row);
    });
}

function populateCustomers() {
    const data = repo.getAll();
    fillData(data);
}

function handleEdit() {
    $(document).on("click", ".btn-edit", function() {
        const id = $(this).closest("tr").data("id");
        const customer = repo.findCustomer(id);
        
        if (customer) {
            $("#cstId").val(customer.CustomerId).attr("disabled", true);
            $("#cstName").val(customer.CustomerName);
            $("#cstAddress").val(customer.CustomerAddress);
            $("section").eq(1).fadeIn(2000);
        }
    });
}

function handleDelete() {
    $(document).on("click", ".btn-delete", function() {
        const id = $(this).closest("tr").data("id");
        repo.deleteCustomer(id);
        populateCustomers();
    });
}

$(document).ready(function() {
    $("section").fadeOut(2000);
    
    $(".navbar-nav > a:first").click(function() {
        $("section").fadeOut(2000);
        $("section:eq(0)").fadeIn(2000);
        populateCustomers();
    });

    $(".navbar-nav > a:eq(1)").click(function() {
        $("section").fadeOut(2000);
        $("section:eq(1)").fadeIn(2000);
    });

    $(".btn-info").click(onUpdate);
    $(".btn-danger").click(function() {
        $("#cstId").val("").attr("disabled", false);
        $("#cstName").val("");
        $("#cstAddress").val("");
        $("section").fadeOut(2000);
    });

    handleEdit();
    handleDelete();
});
