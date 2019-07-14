import React, { Component } from 'react';

export class ServiceForm extends Component {
    constructor(props) {
        super();
    }

    handleSubmit(event) {

    }

    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <label>This is the service form page</label>
            </form>
        );
    }
}

export default ServiceForm;