import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import AppConfig from '../../appconfig.json';
import './Category.css';

class Category extends Component {
    constructor() {
        super();
        this.state = {
            categories: []
        };
    }

    componentDidMount() {
        fetch(AppConfig.apiUrl + '/category/GetCategories')
            .then(results => {
                return results.json();
            })
            .then(data => {
                let cats = data.map((cat) => {
                    return (
                    <div id={cat.categoryId} key={cat.categoryId}
                        className={cat.parentCategoryId ? 'children' : null}>
                            <Link to={{ pathname: `/explore-services/${cat.categoryId}` }}>{cat.categoryName}</Link>                         
                    </div>
                )
            })
            this.setState({ categories: cats });
        });
                                
    }

    render() {
        let categories = null;

        categories = <div className="container">{this.state.categories}</div>

        return categories;
    }
}

export default Category;