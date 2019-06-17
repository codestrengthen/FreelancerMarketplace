import React, { Component } from 'react';
import Services from './Services/Services';

export class ServiceExplorer extends Component {
    //constructor(props) {
    //    super();
    //}

    render() {
        return (
            <Services categoryId={this.props.match.params.categoryId} />
        );
    }
}
